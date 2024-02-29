import { createRouter, createWebHistory } from "vue-router";
import { RouteNames } from "./RouteNames";

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: "/",
            component: (): any => import("@/views/LayoutView.vue"),
            children: [
                {
                    path: "vehicles",
                    name: RouteNames.vehicles,
                    component: (): any => import("@/views/VehiclesView.vue"),

                },
                {
                    path: "",
                    name: RouteNames.home,
                    component: (): any => import("@/views/HomeView.vue"),
                },
            ],
        },
    ],
});

export default router;