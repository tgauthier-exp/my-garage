<script lang="ts" setup>
import { NavBar } from "@/components";
</script>

<template>
  <div>
    <q-layout view="hHh lpr fff">
      <nav-bar />

      <q-page-container>
        <div class="q-pt-md q-px-md">
            <router-view />
        </div>
      </q-page-container>
    </q-layout>
  </div>
</template>