import React from 'react'
import * as Yup from 'yup'
import {Formik, Form, Field, ErrorMessage} from 'formik'

const validationSchema = Yup.object({
    name: Yup.string()
    .required('Name is required')
    .min(2, 'Name must be atleast 2 characters'),
    email: Yup.string()
    .email('Enter a valid email')
    .required('Email is required'),
})
const Formik_demo = () => {
  return (
    <Formik initialValues={{name: '', email: ''}}
    validationSchema={validationSchema}
    onSubmit = {(values) => {
        alert(JSON.stringify(values, null, 2));
    }}
    >
        {({isSubmitting})=>(
            <Form>
                <div>
                    <label htmlFor="name">Name: </label>
                    <Field type="text" name="name" />
                    <ErrorMessage name="name" component="div"/>
                </div>
                <div>
                    <label htmlFor="email">Email: </label>
                    <Field type="email" name="email" />
                    <ErrorMessage name="email" component="div"/>
                </div>
                <button type="submit" disabled={isSubmitting}>Submit</button>
            </Form>
        )}
    </Formik>
  )
}

export default Formik_demo