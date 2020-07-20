import React from 'react';
import { Form, Row, Col } from 'react-bootstrap';

const handleSubmit = (data) => {
  console.log(data);
};

const AddAnimalForm = (props) => {
  return (
    <Row>
      <Col lg='6'>
        <Form onSubmit={handleSubmit} disabled={false}>
          <Form.Group as={Row} controlId='animalName'>
            <Form.Label column sm='2'>
              Name
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animal name.' />
            </Col>
          </Form.Group>
          <Form.Group as={Row} controlId='animalTag'>
            <Form.Label column sm='2'>
              Tag
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animal tag.' />
            </Col>
          </Form.Group>
          <Form.Group as={Row} controlId='animalBirthDate'>
            <Form.Label column sm='2'>
              Birthdate
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animal bitrhdate.' />
            </Col>
          </Form.Group>
          <Form.Group as={Row} controlId='animalBreed'>
            <Form.Label column sm='2'>
              Breed
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animal breed.' />
            </Col>
          </Form.Group>
          <Form.Group as={Row} controlId='animalSex'>
            <Form.Label column sm='2'>
              Sex
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animals sex' />
            </Col>
          </Form.Group>
        </Form>
      </Col>
    </Row>
  );
};

export default AddAnimalForm;
