class LogService {
  info(message: string, payload?: unknown) {
    console.log('[Info]', message, payload);
  }

  warn(message: string, payload?: unknown) {
    console.warn('[Warn]', message, payload);
  }

  error(message: string, payload?: unknown) {
    console.error('[Error]', message, payload);
  }
}

export default new LogService();
