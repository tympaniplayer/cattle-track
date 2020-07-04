import React from 'react';
import Table from 'react-bootstrap/Table';
import CattleRow from './AnimalRow';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
function AnimalList(props) {
  let { cattle } = props;
  let animalRows = cattle.map((animal) => <CattleRow key={animal.tag.toString()} animal={animal} />);
  return (
    <Row>
      <Col lg='6'>
        <Table striped bordered hover size='sm'>
          <thead>
            <tr>
              <th>Name</th>
              <th>Tag</th>
              <th>Age</th>
              <th></th>
            </tr>
          </thead>
          <tbody>{animalRows}</tbody>
        </Table>
      </Col>
    </Row>
  );
}

export default AnimalList;
