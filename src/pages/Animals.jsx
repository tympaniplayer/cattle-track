import React from 'react';
import AnimalList from '../components/cattle/AnimalList';

export default function Cattle(props) {
  return (
    <div>
      <h1>Cattle List</h1>
      <AnimalList {...props} />
    </div>
  );
}
