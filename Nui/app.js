// browser side
window.addEventListener('message', (event) => {
  if (event.data.type === 'init') { OnInit(); console.log("Initializing Nui;"); }
});

function OnInit(){
  $('body').html("<script type=\"text/javascript\" src=\"app.js\" async></script>");
}