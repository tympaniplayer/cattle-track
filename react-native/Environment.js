const ENV = {
  dev: {
    apiUrl: 'http://localhost:44377',
    oAuthConfig: {
      issuer: 'http://localhost:44377',
      clientId: 'CattleTrack_App',
      clientSecret: '1q2w3e*',
      scope: 'CattleTrack',
    },
    localization: {
      defaultResourceName: 'CattleTrack',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44377',
    oAuthConfig: {
      issuer: 'http://localhost:44377',
      clientId: 'CattleTrack_App',
      clientSecret: '1q2w3e*',
      scope: 'CattleTrack',
    },
    localization: {
      defaultResourceName: 'CattleTrack',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
