import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Tarjeta } from 'src/app/Models/tarjeta';
import { TarjetaCreditoService } from '../../Services/tarjeta-credito.service'

@Component({
  selector: 'app-credit-card',
  templateUrl: './credit-card.component.html',
  styleUrls: ['./credit-card.component.css']
})
export class CreditCardComponent implements OnInit {

  listTarjetas : Tarjeta;

  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private toastr: ToastrService, private tarjetaService : TarjetaCreditoService) {
    this.form = this.formBuilder.group({
      Nombre:['',  [Validators.required, Validators.minLength(10), Validators.maxLength(20)]],
      numeroTarjeta:['', [Validators.required, Validators.minLength(16), Validators.maxLength(16)]],
      fechaExp:['' , [Validators.required, Validators.minLength(1)]],
      cvv:['', [Validators.required, Validators.min(1), Validators.max(999)]]
    })
   }

  ngOnInit(): void {
    this.getTarjetas();
  }

  getTarjetas(){
    this.tarjetaService.getAllTarjetas().subscribe( data => {
      console.log(data);
      this.listTarjetas = data;
    }, 
    error => {
      console.log(error);
    });

  }

  SendData(){

    let tarjeta : any = {
      Nombre: this.form.value["Nombre"],
      numeroTarjeta: this.form.value["numeroTarjeta"],
      fechaExp: this.form.value["fechaExp"],
      cvv: this.form.value["cvv"] 
    }

    console.log(tarjeta);

    this.toastr.success('Hello world!', 'Toastr fun!');

  }

}
