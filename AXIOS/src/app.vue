<template>
  <div id="app">
    <form>
      <input v-model="nomeUsuario" placeholder="Digite o nome do usuario">
      <button v-on:click="procurar">Procurar</button>
      <button v-on:click="salvarUsuario">Salvar</button>
    </form>
    <p v-if="usuario.name && usuario.location">
      {{usuario.name}} {{usuario.login}}
      é de 
      {{usuario.location}}
      <br>
      <br>
      Dados do usuáro do github:
      <br>
      ID: <input type="text" v-model="usuario.id">      
      <br>
      Nome: <input type="text" v-model="usuario.name">      
      <br>
      ULR: <input type="text" v-model="usuario.url">      
      <br>
      BLOG: <input type="text" v-model="usuario.blog">      
      <br>
      Tipo: <input type="text" v-model="usuario.type">      
      <br>
      <p v-else>{{mensagemErro}}</p>
    </p>
    <ul>
      <li v-for="usuario in listaUsuarios">    
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
      usuario: [],
      listaUsuarios: [],
      mensagemErro: ''
    }
  },
  methods: {
    procurar () {
      const api = `https://api.github.com/users/${this.nomeUsuario}`
      Vue.axios.get(api).then(response => {
        this.usuario = response.data
      }).catch(e => {
        this.mensagemErro = 'erro ao carregar'
        this.usuario = []
      })
    },
    salvarUsuario () {
      console.log('salvar usuario ' + this.usuario)
      const api = `https://api.github.com/users`
      Vue.axios.post(api, {
        body: this.usuario
      }
      ).then(function (response) {
        console.log(response)
      }).catch(function (error) {
        console.log('Não foi possivel realizar o post' + error)
      })
    }
  },
  created: function () {
    const api = `https://api.github.com/users`
    Vue.axios.get(api).then(response => {
      this.listaUsuarios = response.data
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
