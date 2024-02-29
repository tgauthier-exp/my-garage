<script lang="ts" setup>
import { onMounted, ref } from "vue";
import type { Ref } from "vue";
import type { QTableColumn } from "quasar";
import { vehiclesClient } from "@/repositories";
import type { Vehicle } from "@/repositories/GeneratedClients";

const loading = ref(false);

const columns: Ref<QTableColumn[]> = ref([
  { name: "type", field: "type", label: "Type", align: 'center' },
  { name: "brand", field: "brand", label: "Brand", align: 'center' },
  { name: "model", field: "model", label: "Model", align: 'center' },
]);
const vehicles: Ref<Vehicle[]> = ref([]);

onMounted(async () => {
  loading.value = true;
  const promises = [];
  promises.push(vehiclesClient.getVehicles());
  const result = await Promise.all(promises);
  vehicles.value = result[0];
  loading.value = false;
});

</script>

<template>
  <main>
    <div class="q-pa-md">
      <q-table
        title="Vehicles"
        :rows="vehicles"
        :columns="columns"
        row-key="name"
        separator="cell"
      />
    </div>
  </main>
</template>