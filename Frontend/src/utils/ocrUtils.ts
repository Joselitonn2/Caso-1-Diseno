import { DocumentData, DuaData } from '../models/DuaData';

class OcrUtilsClass {
  async extractText(buffer: ArrayBuffer): Promise<string> {
    // TODO: integración con tesseract.js u otro OCR
    return 'texto detectado';
  }

  parseDocumentText(text: string): Partial<DuaData> {
    // TODO: parsear texto usando reglas avanzadas o LLM
    return {
      importer: 'Importador OCR',
      exporter: 'Exportador OCR',
    };
  }
}

export default new OcrUtilsClass();
