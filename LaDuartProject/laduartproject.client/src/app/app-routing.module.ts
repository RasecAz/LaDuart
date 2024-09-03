import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './components/product/product.component';
import { HomeComponent } from './components/home/home.component';
import { CartComponent } from './components/cart/cart.component';

const routes: Routes = [
  {
    path: "",
    component: ProductComponent,
    pathMatch: "full"
  },
  {
    path: "producto",
    component: ProductComponent,
  },
  {
    path: "home",
    component: HomeComponent,
  },
  {
    path: "compra",
    component: CartComponent
  },
  {
    path: "**",
    pathMatch: "full",
    redirectTo: "producto"
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
