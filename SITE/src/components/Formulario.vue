<template>
  <div class="Formulario">
   <h1>{{titulo}}</h1> 
   <h1>{{usuario.nome}}</h1> 
  </div>
</template>

<script>
export default {
  name: 'Formulario',
  data () {
    return {
      titulo: 'TCE PR',
      usuario: {
        nome: 'Andre',
        sobrenome: 'Camilo'
      }
    }
  }
}
</script>

<style scoped>
</style>
