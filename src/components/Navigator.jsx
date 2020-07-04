import React from 'react';
import Navbar from 'react-bootstrap/Navbar';
import Nav from 'react-bootstrap/Nav';
import NavDropdown from 'react-bootstrap/NavDropdown';
function Navigator() {
  return (
    <Navbar bg='dark' expand='lg' variant='dark'>
      <Navbar.Brand href='/'>Cattle Track</Navbar.Brand>
      <Navbar.Toggle aria-controls='basic-navbar-nav' />
      <Navbar.Collapse id='basic-navbar-nav'>
        <Nav className='mr-auto'>
          <Nav.Link href='/'>Home</Nav.Link>
          <NavDropdown title='Cattle' id='basic-nav-dropdown'>
            <NavDropdown.Item href='/animal/list'>Cattle List</NavDropdown.Item>
            <NavDropdown.Item href='/animal/add'>Add Animal</NavDropdown.Item>
          </NavDropdown>
          <Nav.Link href='/locations'>Locations</Nav.Link>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default Navigator;
