export const environment = {
  production: false,
  application: {
    baseUrl: 'https://localhost:4200/',
    name: 'MyCompany Project',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44315/',
    redirectUri: window.location.origin,
    clientId: 'mycompany_project_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone mycompany_project',
  },
  apis: {
    default: {
      url: 'https://localhost:44315',
      rootNamespace: 'MyCompany.Project',
    },
  },
};
