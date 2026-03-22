export interface DocumentData {
  name: string;
  type: 'xlsx' | 'docx' | 'pdf' | 'image' | 'pdf-scan';
  content: ArrayBuffer;
  extracted?: Partial<DuaData>;
}

export interface DuaData {
  importer: string;
  exporter: string;
  invoiceNumber: string;
  incoterm: string;
  currency: string;
  totalValue: number;
  tariffDescription?: string;
  countryOfOrigin: string;
  customsRegime: string;
  documents: DocumentData[];
}
