import { DocumentData, DuaData } from '../models/DuaData';

class FileUtilsClass {
  async loadDocuments(folderPath: string): Promise<DocumentData[]> {
    // TODO: leer todos los ficheros en folderPath desde el FS o API
    return [];
  }

  async writeDuaDocument(templatePath: string, duaData: DuaData): Promise<void> {
    // TODO: escribir palabra Word usando Office SDK o docx
    console.log('write DUA', templatePath, duaData);
  }
}

export default new FileUtilsClass();
