body 

{
font-family: "Courier New" ; background:url("https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/FoggDam-NT.jpg/800px-FoggDam-NT.jpg");  
 

}

h1
{
color:grey;
transform: rotateY(1deg);
animation:animate 2s ease-in-out infinite;
}

@keyframes animate{

0%{   
  transform: rotateY(360deg); 
}
 }     
 100%{
   transform: rotateY(720deg); 
 }
}
img{
    height: 500px;
    width: 500px;
    padding: 10px;
}
