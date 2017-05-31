// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import VueRouter from 'vue-router'
import Formulario from './components/Formulario'
import Informacao from './components/Informacao'

Vue.use(VueRouter)

const routes = [
  { path: '/', component: Formulario },
  { path: '/Informacao', component: Informacao }
]

Vue.config.productionTip = false

const rotas = new VueRouter({
  routes, // short for routes: routes
  mode: 'history'
})

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App },
  rotas
})
