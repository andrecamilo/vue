import Vue from 'vue'
import Router from 'vue-router'
import Formulario from '@/components/Formulario'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Formulario',
      component: Formulario
    }
  ]
})
