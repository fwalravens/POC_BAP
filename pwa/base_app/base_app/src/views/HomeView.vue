<template>
  <div class="home">
    <button
    @click="loadForecasts">
      GET Forecasts
    </button>
      <button 
    @click="openPrinterDialog" style="display:block;margin: 0 auto;">
      Print
    </button>
    <table>
      <tr>
        <th>Datum</th>
        <th>Temperatuur (°C)</th>
        <th>Temperatuur (°F)</th>
        <th>Samenvatting</th>
      </tr>
      <tr
        v-for="forecast in forecasts">
          <td>{{forecast.date}}</td>
          <td>{{forecast.temperatureC}}</td>
          <td>{{forecast.temperatureF}}</td>
          <td>{{forecast.summary}}</td>
      </tr>
    </table>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'HomeView',
  components: {
    HelloWorld
  },
  data(){
    return{
      forecasts:[]
    }
  },
  created() {
  },
  methods:{
    loadForecasts(){
      axios.get('https://localhost:5001/WeatherForecast')
          .then(response=>{
            this.forecasts=response.data
          })
          .catch(error=>{
            console.log(error)
          })
    },
    openPrinterDialog(){
      window.print()
    }
  }
}
</script>
<style>
  table{
    margin:0 auto;
    margin-top: 10px;
    border:1px solid black;
    border-collapse: collapse;
  }
  table>tr>th{
    padding: 5px;
    border: 1px solid black;
    border-collapse: collapse;
  }
  table>tr>td{
    padding: 5px;
    border: 1px solid black;
    border-collapse: collapse;
  }
</style>
