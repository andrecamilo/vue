<template>
  <div id="app">
    <Usuario/>     
  </div>
</template>

<script>
import Vue from 'vue'
import Axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, Axios)

import Usuario from './components/Usuario'

export default {
  name: 'app',
  components: {
    Usuario
  }
}
</script>

<style>

</style>
