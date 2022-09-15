import React from "react";
import { Container } from "react-bootstrap";
import NbNavbar from "./NbNavbar";

function About() {
  return (
    <div>
      <NbNavbar />
      <Container>
        <h1>About Us</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Porro repellat, sed provident pariatur vero distinctio quod error eos cumque saepe dignissimos sint. Ad eos, hic dignissimos fugiat autem vitae iusto.</p>
        <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eveniet maiores ut temporibus debitis rerum minus asperiores numquam atque ipsum sint.</p>
      </Container>
    </div>
  );
}
export default About;
