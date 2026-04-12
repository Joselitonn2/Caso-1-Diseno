import { User } from '../models/User';

class AuthServiceClass {
  async login(username: string, password: string): Promise<User> {
    // TODO: Integrar con API de Azure Entra ID y validación de OTP.
    return { id: 'demo', name: username, roles: ['CustomsAgent'], token: 'demo-token' };
  }

  logout() {
    // TODO: limpiar token y sesión.
    console.log('logout');
  }
}

export default new AuthServiceClass();
