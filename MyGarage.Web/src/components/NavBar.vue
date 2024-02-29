<script lang="ts" setup>
import { useRouter } from "vue-router";
import { RouteNames } from "@/router/RouteNames";

const router = useRouter();

const isRouteActive = (routeName: string): boolean => {
    return router.currentRoute.value.name === routeName;
};

</script>

<template>
    <q-header elevated class="bg-primary text-white">
        <q-toolbar>
            <q-btn icon="mdi-home" label="Home" :to="{ name: RouteNames.home }" :class="{ active: isRouteActive(RouteNames.home) }" flat />
            <q-btn icon="mdi-home" label="Vehicles" :to="{ name: RouteNames.vehicles }" :class="{ active: isRouteActive(RouteNames.vehicles) }" flat />
        </q-toolbar>
    </q-header>
</template>

<style lang="scss" scoped>
.active {
    background-color: rgb(255 255 255 / 20%);
}

.dropdown-active {
    color: white;
    background-color: var(--q-primary);
}
</style>