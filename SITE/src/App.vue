<template>
  <div id="app">
    <img src="./assets/logo.png">
    <br />
    <!--
    <router-link v-bind:to="'/'">Formulario</router-link>
    <router-link v-bind:to="'/Informacao'">Informacao</router-link>
    <router-link v-bind:to="'/Usuario'">Usuario</router-link>    
    <router-view></router-view>
    <Formulario></Formulario>
    <Informacao></Informacao>
    -->
    <Usuario></Usuario>
  </div>
</template>

<script>
import Formulario from './components/Formulario'
import Usuario from './components/Usuario'
import Informacao from './components/Informacao'

export default {
  name: 'app',
  components: {
    Formulario, Usuario, Informacao
  }
}

</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
