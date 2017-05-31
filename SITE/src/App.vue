<template>
  <div id="aplicacao">
  <img src="./assets/logo.png">
  <br />
  <router-link v-bind:to="'/'">Formulario</router-link>
  <router-link v-bind:to="'/Informacao'">Informacao</router-link>
  <router-view></router-view>
  </div>
</template>

<script>
import Formulario from './components/Formulario'

export default {
  name: 'aplicacao',
  components: {Formulario}
}
</script>

<style>
#aplicacao {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
