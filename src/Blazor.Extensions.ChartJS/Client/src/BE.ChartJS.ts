import { Chart, ChartConfiguration, defaults } from "chart.js";
import { initializeChartJS } from "./InitializeChartJS";

const createBEChart = (chartId: string, params: ChartConfiguration): Chart => {
  console.log(params);
  console.log(defaults.controllers);

  return new Chart(chartId, params);
};

export { initializeChartJS, createBEChart };
