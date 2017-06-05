import Vue from 'vue'
import Router from 'vue-router'
import Usuario from '@/components/Usuario'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Usuario',
      component: Usuario
    }
  ]
})
