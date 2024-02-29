import { generatedClientsAxiosInstance } from "./AxiosInstance";
import { settings } from "@/settings";
import {
    VehiclesClient,
} from "./GeneratedClients";

const vehiclesClient = new VehiclesClient(`${settings.webApi.baseUrl}`, generatedClientsAxiosInstance);

export {
    vehiclesClient,
};