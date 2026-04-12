import axios from 'axios';

const api = axios.create({
  baseURL: process.env.AZURE_API_BASE_URL || '',
  headers: { 'Content-Type': 'application/json' },
});

export const AzureApiClient = {
  async post(path: string, data: unknown) {
    const res = await api.post(path, data);
    return res.data;
  },
};
