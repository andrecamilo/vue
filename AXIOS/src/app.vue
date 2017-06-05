<template>
  <div id="app">
    <form>
      <input v-model="nomeUsuario" placeholder="Digite o nome do usuario">
      <button v-on:click="procurar">Procurar</button>
    </form>
    <p v-if="data.name && data.location">
      {{data.name}} {{data.login}}
      é de 
      {{data.location}}
      <br>
      <br>
      Dados do usuáro do github:
      <br>
      ID: {{data.id}}
      <br>
      ULR: {{data.url}}
      <br>
      BLOG: {{data.blog}}
      <br>
      Tipo: {{data.type}}
      <br>
      <p v-else>{{mensagemErro}}</p>
    </p>
    <ul>
      <li v-for="usuario in usuarios">    
        <span>
            {{usuario.id}} {{usuario.login}}
        </span>
      </li>
    </ul>
  </div>
</template>

<script>
import Vue from 'vue'
import Axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, Axios)

export default {
  data () {
    return {
      nomeUsuario: '',
      data: [],
      usuarios: [],
      mensagemErro: ''
    }
  },
  methods: {
    procurar () {
      const api = `https://api.github.com/users/${this.nomeUsuario}`
      Vue.axios.get(api).then(response => {
        this.data = response.data
      }).catch(e => {
        this.mensagemErro = 'erro ao carregar'
        this.data = []
      })
    }
  },
  created: function () {
    const api = `https://api.github.com/users`
    Vue.axios.get(api).then(response => {
      this.usuarios = response.data
    })
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
