<template>
  <div id="app">
    <img src="./assets/logo.png">
    <br />
    
    <Usuario></Usuario>
    <!-- 
    <router-link v-bind:to="'/'">Formulario</router-link>
    <router-link v-bind:to="'/Informacao'">Informacao</router-link>
    <Formulario msg="mensagem que aparece no rodape (com bind)"></Formulario>
    -->
    
    <!-- 
    <router-view></router-view> 
    -->
  </div>
</template>

<script>

import Formulario from './components/Formulario'
import Usuario from './components/Usuario'
import Informacao from './components/Informacao'

export default {
  name: 'app',
  components: {
    Usuario, Formulario, Informacao
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
