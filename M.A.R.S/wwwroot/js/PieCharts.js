function GenerateInputPieChart(pieElementsInput) {

    am4core.useTheme(am4themes_animated);
    var chart = am4core.create("chartdiv1", am4charts.PieChart3D);
    chart.hiddenState.properties.opacity = 0; // this creates initial fade-in

    chart.legend = new am4charts.Legend();
    chart.data = pieElementsInput;

    var series = chart.series.push(new am4charts.PieSeries3D());
    series.dataFields.value = "value";
    series.dataFields.category = "name";
}

function GenerateOutputPieChart(pieElementsInput) {

    am4core.useTheme(am4themes_animated);
    var chart = am4core.create("chartdiv2", am4charts.PieChart3D);
    chart.hiddenState.properties.opacity = 0; // this creates initial fade-in

    chart.legend = new am4charts.Legend();

    chart.data = pieElementsInput;

    var series = chart.series.push(new am4charts.PieSeries3D());
    series.dataFields.value = "value";
    series.dataFields.category = "name";
}

