import { DuaData } from '../models/DuaData';

export const validateDuaData = (data: DuaData): string[] => {
  const errors: string[] = [];
  if (!data.importer) errors.push('Importador requerido');
  if (!data.exporter) errors.push('Exportador requerido');
  if (data.totalValue <= 0) errors.push('Valor total debe ser mayor que cero');
  if (!data.currency) errors.push('Moneda requerida');
  // TODO: más validaciones de consistencia y fechas.
  return errors;
};
