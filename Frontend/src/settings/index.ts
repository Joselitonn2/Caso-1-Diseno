const settings = {
  azure: {
    keyVaultName: process.env.AZURE_KEY_VAULT || '',
  },
  api: {
    baseUrl: process.env.REACT_APP_API_BASE_URL || '',
  },
};

export default settings;
