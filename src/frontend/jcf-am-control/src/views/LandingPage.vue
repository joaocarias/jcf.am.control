<script setup lang="ts">
 
</script>

<template>
    <div>
      <!-- Navbar -->
      <header class="bg-white shadow-md fixed w-full z-10">
        <nav class="container mx-auto px-4 py-3 flex justify-between items-center">
          <h1 class="text-xl font-bold text-gray-800">JCF AM Control</h1>
          <ul class="flex space-x-6 text-gray-700">
            <li><a href="#inicio" class="hover:text-blue-500">Início</a></li>
            <li><a href="#sobre" class="hover:text-blue-500">Sobre</a></li>
            <li><a href="#contato" class="hover:text-blue-500">Contato</a></li>
            <li><a href="#login" class="hover:text-blue-500">Login</a></li>
          </ul>
        </nav>
      </header>
  
      <!-- Hero Section -->
      <section id="inicio" class="pt-28 bg-gray-50 py-20">
        <div class="container mx-auto px-4 text-center">
          <h2 class="text-4xl font-bold text-gray-800 mb-4">Bem-vindo ao JCF AM Control</h2>
          <p class="text-gray-600 max-w-2xl mx-auto">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique.</p>
        </div>
      </section>
  
      <!-- Sobre Section -->
      <section id="sobre" class="bg-white py-20">
        <div class="container mx-auto px-4 text-center">
          <h2 class="text-3xl font-semibold text-gray-800 mb-4">Sobre</h2>
          <p class="text-gray-600 max-w-2xl mx-auto">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque aliquam odio et faucibus. Nulla rhoncus feugiat eros quis consectetur.</p>
        </div>
      </section>
  
      <!-- Contato Section -->
      <section id="contato" class="bg-gray-50 py-20">
        <div class="container mx-auto px-4 text-center">
          <h2 class="text-3xl font-semibold text-gray-800 mb-4">Contato</h2>
          <p class="text-gray-600 max-w-2xl mx-auto">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis a metus ac nulla consequat aliquet id quis turpis.</p>
        </div>
      </section>
  
      <!-- Login Section -->
      <section id="login" class="bg-white py-20">
        <div class="container mx-auto px-4 text-center">
          <h2 class="text-3xl font-semibold text-gray-800 mb-4">Login</h2>
          <p class="text-gray-600 max-w-2xl mx-auto">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum feugiat, sapien ultrices fermentum congue, quam velit gravida quam.</p>
          <button class="mt-6 px-6 py-2 bg-blue-600 text-white rounded hover:bg-blue-700">Acessar</button>
        </div>
      </section>
    </div>
  </template>
  
  <script lang="ts" setup>
  // Por enquanto nenhum script adicional
  </script>
  
  <style scoped>
  html {
    scroll-behavior: smooth;
  }
  </style>
  