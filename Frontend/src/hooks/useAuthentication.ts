import { useState } from 'react';
import { User } from '../models/User';
import AuthService from '../services/AuthService';

export const useAuthentication = () => {
  const [user, setUser] = useState<User | null>(null);

  const login = async (username: string, password: string) => {
    const result = await AuthService.login(username, password);
    setUser(result);
  };

  const logout = () => {
    AuthService.logout();
    setUser(null);
  };

  return { user, login, logout };
};
