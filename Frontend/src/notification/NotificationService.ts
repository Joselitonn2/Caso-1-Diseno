export class NotificationService {
  static notify(message: string) {
    // TODO: implementar websocket / polling para callbacks y suscripciones
    console.info('[Notification]', message);
  }
}
