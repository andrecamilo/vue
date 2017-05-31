<template>
  <div class="Formulario">
    <h1>{{titulo}}</h1> 
    <h1 v-if="mostrarNome">{{usuario.nome}} {{usuario.sobrenome}}</h1> 
    <h1 v-else>pessoa sem nome</h1>
   
    <br />
    <h3>Endereço: {{enderecoCompleto}}</h3>
   
    <ul>
      <li v-for="item in itens"> {{item.titulo}}</li>
    </ul>
   
    <button v-on:click="estudar('estou estudando')">Estudar</button>

    <input type="text" v-on:keyup="digitar" v-on:keyup.enter="pressionadoEnter">
    <br />
    <br />

    <label> Nome: </label> <input type="text" v-model="usuario.nome">
    <label> Sobrenome: </label> <input type="text" v-model="usuario.sobrenome">
    <br />
    <br />
    <label> Cidade: </label> <input type="text" v-model="usuario.cidade">
    <label> Estado: </label> <input type="text" v-model="usuario.estado">
    <br />
    <br />

    <h3>{{msg}}</h3>
  </div>
</template>

<script>
export default {
  name: 'Formulario',
  props: {
    msg: {
      type: String,
      default: 'mensagem de rodape'
    }
  },
  data () {
    return {
      titulo: 'TCE PR',
      usuario: {
        nome: 'Andre',
        sobrenome: 'Camilo',
        estado: 'Parana',
        cidade: 'campo largo'
      },
      mostrarNome: true,
      itens: [
        {titulo: 'programador'},
        {titulo: 'pai'},
        {titulo: 'marido'}
      ]
    }
  },
  methods: {
    estudar: function (param) {
      alert(param)
    },
    digitar: function (e) {
      console.log(e.target.value)
    },
    pressionadoEnter: function () {
      console.log('a tecla enter foi pressionada')
    }
  },
  computed: {
    enderecoCompleto: function () {
      return this.usuario.cidade + ', ' + this.usuario.estado
    }
  }
}
</script>

<style scoped> </style>
