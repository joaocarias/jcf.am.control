import { createRouter, createWebHistory } from 'vue-router'
import LandingPage from '@/views/LandingPage.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: LandingPage
  },
  // Outras páginas serão adicionadas aqui
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
