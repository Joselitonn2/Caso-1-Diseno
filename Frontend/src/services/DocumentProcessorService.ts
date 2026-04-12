import { DocumentData, DuaData } from '../models/DuaData';
import FileUtils from '../utils/fileUtils';
import OcrUtils from '../utils/ocrUtils';
import { AdapterService } from './AdapterService';

class DocumentProcessorServiceClass {
  async readDocuments(folderPath: string): Promise<DocumentData[]> {
    // Leer diferentes formatos (xlsx, docx, pdf, jpg, png) con múltiples parsers
    return FileUtils.loadDocuments(folderPath);
  }

  async extractData(docs: DocumentData[]): Promise<DuaData> {
    const extracted = await Promise.all(docs.map(async (doc) => {
      if (doc.type === 'image' || doc.type === 'pdf-scan') {
        const text = await OcrUtils.extractText(doc.content);
        return OcrUtils.parseDocumentText(text);
      }
      return doc.extracted || {};
    }));

    // TODO: lógica semántica avanzada basada en customs terminology
    return AdapterService.mergeToDua(extracted);
  }

  async writeDua(templatePath: string, data: DuaData): Promise<void> {
    // TODO: rellenar plantilla Word, con indicadores de colores
    await FileUtils.writeDuaDocument(templatePath, data);
  }
}

export const DocumentProcessorService = new DocumentProcessorServiceClass();
