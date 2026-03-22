class ExceptionHandler {
  handle(error: unknown): void {
    // TODO: integración con Azure Application Insights
    console.error('[Exception]', error);
  }
}

export default new ExceptionHandler();
