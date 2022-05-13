<template>
  <div>
    <form>
      <label>Datum</label>
      <input type="datetime-local" id="date">
      <label>Temperatuur (°C)</label>
      <input type="number" id="tempC">
      <label>Samenvatting</label>
      <input type="text" id="summary">
      <button type="button"
              @click="submitForecast">
        POST Forecasts
      </button>
    </form>
  </div>


</template>
<script>
import axios from 'axios'

export default {
  data() {
    return {
      forecast: {},
    }
  },
  methods: {
    async submitForecast() {
      const summary = document.getElementById("summary").value
      const date = document.getElementById("date").value
      const tempC = document.getElementById("tempC").value
      this.forecast = {
        'date': date,
        'summary': summary,
        'temperatureC': parseInt(tempC)
      }
      await axios.post(`https://localhost:5001/WeatherForecast`, this.forecast)
          .catch(error => {
            console.log(error)
          })
    }
  }
}
</script>
<style>
input {
  display: block;
  margin: 0 auto;
  margin-bottom: 1rem;
}

label {
  font-weight: bold;
}
</style>