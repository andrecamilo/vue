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
      usuarios: [
        {
          nome: 'Aecio',
          email: 'Aecio@gmail.com',
          conectado: false
        },
        {
          nome: 'lula',
          email: 'lula@gmail.com',
          conectado: false
        },
        {
          nome: 'Dilma',
          email: 'Dilma@gmail.com',
          conectado: false
        }
      ]
    }
  },
  methods: {
    adicionarUsuario: function (e) {
      console.log('add')
      this.usuarios.push({
        nome: this.novoUsuario.nome,
        email: this.novoUsuario.email,
        conectado: false}
      )
      e.preventDefault()
    },
    excluirUsuario: function (usuario) {
      this.usuarios.splice(this.usuarios.indexOf(usuario))
    }
  },
  created: function () {
    this.$http.get('https://jsonplaceholder.typicode.com/users')
    .then(function (response) {
      console.log(response.data)
    })
  }
}
</script>
  .conectado {
      text-decoration: line-through;
  }
<style scoped> </style>
