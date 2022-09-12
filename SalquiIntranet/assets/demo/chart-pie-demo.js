// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';

// Pie Chart Example
var ctx = document.getElementById("myPieChart");
var myPieChart = new Chart(ctx, {
  type: 'pie',
  data: {
    labels: ["Cartago", "Alajuela", "San José", "Guanacaste","Heredia","Puntarenas","Limón"],
    datasets: [{
      data: [20.75, 15.58, 11.25, 13.38,12.21, 15.58, 11.25],
      backgroundColor: ['#007bff', '#dc3545','#6f42c1','#42c1c1', '#ffc107','#e27a3f', '#28a745'],
    }],
  },
});
