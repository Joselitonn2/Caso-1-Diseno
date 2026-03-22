import { DuaData, DocumentData } from '../models/DuaData';

class AdapterServiceClass {
  mergeToDua(extracted: Partial<DuaData>[]): DuaData {
    // Adapter pattern para mapear fields de cada source al modelo DUA
    const result: DuaData = {
      importer: '',
      exporter: '',
      invoiceNumber: '',
      currency: '',
      totalValue: 0,
      countryOfOrigin: '',
      incoterm: '',
      customsRegime: '',
      documents: [],
    };

    extracted.forEach((item) => {
      Object.assign(result, item);
    });

    return result;
  }
}

export const AdapterService = new AdapterServiceClass();
