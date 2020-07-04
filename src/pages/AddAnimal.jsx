import React from 'react';
import {} from 'react-bootstrap';
import AddAnimalForm from '../components/cattle/AddAnimalForm';

import '../App.css';

const AddAnimal = (props) => {
  return (
    <div>
      <h2 className='margin-top'>Enter Animal Information</h2>
      <AddAnimalForm {...props} />
    </div>
  );
};

export default AddAnimal;
