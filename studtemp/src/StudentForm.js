import React, { useState } from "react";
import { Form, Button, Col, Row } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css"; // Import Bootstrap CSS
import "bootstrap-icons/font/bootstrap-icons.css"; // Import Bootstrap Icons
import "animate.css/animate.min.css"; // Import Animate.css

const StudentForm = () => {
  // Initialize state variables for form inputs
  const [studentId, setStudentId] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [dateOfBirth, setDateOfBirth] = useState("");
  const [gender, setGender] = useState("");
  const [classId, setClassId] = useState("");

  // Handle form submission
  const handleSubmit = (e) => {
    e.preventDefault();
    // Do something with the form data, such as sending it to a server
    console.log({
      studentId,
      firstName,
      lastName,
      dateOfBirth,
      gender,
      classId,
    });
  };

  // Handle input changes
  const handleChange = (e) => {
    const { name, value } = e.target;
    switch (name) {
      case "studentId":
        setStudentId(value);
        break;
      case "firstName":
        setFirstName(value);
        break;
      case "lastName":
        setLastName(value);
        break;
      case "dateOfBirth":
        setDateOfBirth(value);
        break;
      case "gender":
        setGender(value);
        break;
      case "classId":
        setClassId(value);
        break;
      default:
        break;
    }
  };

  return (
    // Add animation class to the form
    <Form onSubmit={handleSubmit} className="animate__animated animate__fadeIn">
      <h1 className="text-center mb-4">Student Form</h1>
      <Row className="mb-3">
        <Form.Group as={Col} controlId="studentId">
          <Form.Label>
            <i className="bi bi-person-fill me-2"></i>
            Student ID
          </Form.Label>
          <Form.Control
            type="text"
            name="studentId"
            value={studentId}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group as={Col} controlId="classId">
          <Form.Label>Class ID</Form.Label>
          <Form.Control
            type="text"
            name="classId"
            value={classId}
            onChange={handleChange}
            required
          />
        </Form.Group>
      </Row>
      <Row className="mb-3">
        <Form.Group as={Col} controlId="firstName">
          <Form.Label>
            <i className="bi bi-person-fill me-2"></i>
            First Name
          </Form.Label>
          <Form.Control
            type="text"
            name="firstName"
            value={firstName}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group as={Col} controlId="lastName">
          <Form.Label>
            <i className="bi bi-person-fill me-2"></i>
            Last Name
          </Form.Label>
          <Form.Control
            type="text"
            name="lastName"
            value={lastName}
            onChange={handleChange}
            required
          />
        </Form.Group>
      </Row>
      <Row className="mb-3">
        <Form.Group as={Col} controlId="dateOfBirth">
          <Form.Label>
            <i className="bi bi-calendar me-2"></i>
            Date of Birth
          </Form.Label>
          <Form.Control
            type="date"
            name="dateOfBirth"
            value={dateOfBirth}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group as={Col} controlId="gender">
          <Form.Label>
            <i className="bi bi-gender-ambiguous me-2"></i>
            Gender
          </Form.Label>
          <Form.Check
            type="radio"
            name="gender"
            value="Female"
            label="Female"
            onChange={handleChange}
            required
          />
          <Form.Check
            type="radio"
            name="gender"
            value="Male"
            label="Male"
            onChange={handleChange}
            required
          />
          <Form.Check
            type="radio"
            name="gender"
            value="Other"
            label="Other"
            onChange={handleChange}
            required
          />
        </Form.Group>
      </Row>
      <Button
        variant="primary"
        type="submit"
        className="animate__animated animate__pulse"
      >
        Submit
      </Button>
    </Form>
  );
};

export default StudentForm;
