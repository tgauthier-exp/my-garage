import axios from "axios";
import type { AxiosInstance } from "axios";

const createGeneratedClientsAxiosInstance = (allowTransformation = true): AxiosInstance => {
  const axiosInstance = axios.create({
    transformResponse: allowTransformation ? undefined : [(data): any => data],
  });
  return axiosInstance;
};

const generatedClientsAxiosInstance: AxiosInstance = createGeneratedClientsAxiosInstance(false);

export { generatedClientsAxiosInstance };