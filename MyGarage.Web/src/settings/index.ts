export const settings = {
    environment: import.meta.env.VITE_APP_ENV as string,
    environmentName: import.meta.env.VITE_APP_ENV_NAME as string,
    webApi: {
        baseUrl: import.meta.env.VITE_APP_WEB_API_BASE_URL as string,
    },
};