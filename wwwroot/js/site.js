//this function is used both by HForecast and DForecast
function toggleCollapse(element) {
    if(element.classList.contains('collapsed')) {
        element.classList.remove('collapsed')
    } else {
        element.classList.add('collapsed')
    }
}