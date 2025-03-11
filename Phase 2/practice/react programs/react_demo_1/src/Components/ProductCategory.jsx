import React from 'react'

const ProductCategory = () =>{
    return (
        <div>
            <form>
                <h3>Products</h3>
                <label for="product">Products Category  </label>
                <select name="product" id="product">
                    <option value="">--Please choose an option--</option>
                    <option value="Kitchen">Kitchen</option>
                    <option value="Interiors">Interiors</option>
                    <option value="Furnitures">Furnitures</option>
                    <option value="Food">Food</option>
                    <option value="Clothing">Clothing</option>
                </select>
            </form>
        </div>
    )
}

export default ProductCategory;