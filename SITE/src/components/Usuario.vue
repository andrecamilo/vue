<template>
  <div class="Usuario">
    <h1>Lista de usuarios</h1>
    <form v-on:submit="adicionarUsuario">
      <input type="text" v-model="novoUsuario.nome" placeholder="Digite o nome do usuario">
      <br />
      <input type="text" v-model="novoUsuario.email" placeholder="Digite o email do usuario">
      <br />
      <input type="submit" value="Gravar">
    </form>
    <ul>
      <li v-for="usuario in usuarios">    
        <input type="checkbox" v-model="usuario.conectado">
        <span :class="{conectado: usuario.conectado}">
            {{usuario.nome}} {{usuario.email}} <button v-on:click="excluirUsuario(usuario)">Excluir</button>
        </span>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: 'Usuario',
  data () {
    return {
      novoUsuario: {},
      usuarios: [ ]
    }
  },
  methods: {
    adicionarUsuario: function () {
      console.log(this.novoUsuario)
      this.$http.post('http://localhost:5000/api/usuario', this.novoUsuario, {
        headers: [
        { 'Content-Type': 'application/json' },
        { 'Access-Control-Allow-Origin': '*' },
        {'Access-Control-Allow-Headers': 'Content-Type'},
        {'Access-Control-Allow-Methods': 'GET,PUT,PATCH,POST,DELETE'} ]
      })
    },
    excluirUsuario: function (usuario) {
      this.usuarios.splice(this.usuarios.indexOf(usuario))
    }
  },
  created: function () {
    // this.$http.get('https://jsonplaceholder.typicode.com/users')
    this.$http.get('http://localhost:5000/api/usuario')
    .then(function (response) {
      this.usuarios = response.data
    })
  }
}
</script>
  
<style scoped>
  .conectado {
    text-decoration: line-through;
  }
</style>
