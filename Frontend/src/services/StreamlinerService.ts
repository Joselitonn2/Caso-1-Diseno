import { NotificationService } from '../notification/NotificationService';
import { DocumentProcessorService } from './DocumentProcessorService';

interface StreamlinerInput {
  folderPath: string;
  templatePath: string;
}

class StreamlinerServiceClass {
  async start(input: StreamlinerInput, onProgress: (percent: number) => void) {
    onProgress(10);
    const documents = await DocumentProcessorService.readDocuments(input.folderPath);
    onProgress(40);
    const data = await DocumentProcessorService.extractData(documents);
    onProgress(70);
    await DocumentProcessorService.writeDua(input.templatePath, data);
    onProgress(90);

    NotificationService.notify('DUA generated successfully');
    onProgress(100);
  }
}

export const StreamlinerService = new StreamlinerServiceClass();
