"use strict";(self["webpackChunkbase_app"]=self["webpackChunkbase_app"]||[]).push([[443],{6624:function(t,e,a){a.r(e),a.d(e,{default:function(){return p}});var s=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",[a("form",[a("label",[t._v("Datum")]),a("input",{attrs:{type:"datetime-local",id:"date"}}),a("label",[t._v("Temperatuur (°C)")]),a("input",{attrs:{type:"number",id:"tempC"}}),a("label",[t._v("Samenvatting")]),a("input",{attrs:{type:"text",id:"summary"}}),a("button",{attrs:{type:"button"},on:{click:t.submitForecast}},[t._v(" POST Forecasts ")])])])},n=[],u=a(6166),r=a.n(u),l={data(){return{forecast:{}}},methods:{async submitForecast(){const t=document.getElementById("summary").value,e=document.getElementById("date").value,a=document.getElementById("tempC").value;this.forecast={date:e,summary:t,temperatureC:parseInt(a)},await r().post("https://localhost:5001/WeatherForecast",this.forecast).catch((t=>{console.log(t)}))}}},c=l,o=a(1001),m=(0,o.Z)(c,s,n,!1,null,null,null),p=m.exports}}]);
//# sourceMappingURL=about.c82d6da6.js.map