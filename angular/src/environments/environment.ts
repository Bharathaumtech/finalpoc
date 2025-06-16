import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'mycompany_project',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44315/',
    redirectUri: baseUrl,
    clientId: 'mycompany_project_App',
    responseType: 'code',
    scope: 'offline_access mycompany_project',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44315',
      rootNamespace: 'mycompany_project',
    },
  },
} as Environment;
