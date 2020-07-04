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
          <Form.Group as={Row} controlId='formName'>
            <Form.Label column sm='2'>
              Name
            </Form.Label>
            <Col sm='10'>
              <Form.Control type='text' placeholder='Enter animal name.' />
            </Col>
          </Form.Group>
        </Form>
      </Col>
    </Row>
  );
};

export default AddAnimalForm;
