<template>
  <div id="app">
    
    <h1>Procurar usuario</h1>
    <div class="form-group col-md-4">      
      <input class="form-control" v-model="nomeUsuario" placeholder="Digite o nome do usuario">
    </div>
    <div class="col-md-4">
      <button class="btn btn-primary btn-block" v-on:click="procurarUsuario">Procurar</button>
    </div>
    <div class="col-md-4">
      <button class="btn btn-primary btn-block" v-on:click="salvarUsuario">Salvar</button>
    </div>

    <div class="form-group">
      <div v-if="usuario.name && usuario.location">
        <div class="col-md-12">
          <h3> {{usuario.name}} {{usuario.login}} é de {{usuario.location}} </h3> 
        </div>
        <br>
        <div class="col-md-12">
          <h1> Dados do usuário </h1> 
        </div>
        <div class="col-md-4">
          <label class="control-label"> ID</label>
          <input class="form-control" type="text" v-model="usuario.id">      
        </div>
        <div class="col-md-4">
          <label class="control-label"> Nome</label>
          <input class="form-control" type="text" v-model="usuario.name">      
        </div>
        <div class="col-md-4">
          <label class="control-label"> Url</label>
          <input class="form-control" type="text" v-model="usuario.url">      
        </div>
        <div class="col-md-4">
          <label class="control-label"> Blog</label>
          <input class="form-control" type="text" v-model="usuario.blog">      
        </div>
        <div class="col-md-4">
          <label class="control-label"> Tipo</label>
          <input class="form-control"  type="text" v-model="usuario.type">      
        </div>
        <div class="col-md-4">
          <label class="control-label"> Endereço</label>
          <input class="form-control"  type="text" v-model="usuario.location">      
        </div>
      </div>
      <div v-else  class="col-md-12">
        <h3 class="control-label"> {{mensagemErro}}</h3>
      </div>
    </div>

    <div class="form-group col-md-12" >
    <br/>
      <table>
        <tr>
          <th>ID</th>
          <th>Nome</th>
          <th>Tipo</th>
          <th>Url do repositorio</th>
        </tr>
        <tr v-for="usuario in listaUsuarios">    
          <th>{{usuario.id}} </th>
          <th>{{usuario.login}}</th>
          <th>{{usuario.type}}</th>
          <th>{{usuario.repos_url}}</th>
        </tr>  
        </table>
      </ul>
    </div>
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
    procurarUsuario () {
      const api = `https://api.github.com/users/${this.nomeUsuario}`
      Vue.axios.get(api).then(response => {
        this.usuario = response.data
      }).catch(e => {
        this.mensagemErro = 'Não foi possivel carregar o usuario'
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

table {
    font-family: arial, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

td, th {
    border: 1px solid #dddddd;
    text-align: left;
    padding: 8px;
}

tr:nth-child(even) {
    background-color: #dddddd;
}

</style>
