SELECT [id]
      ,[num_doc]
      ,[enable]
      ,[valor] as valor_cobrado
	  ,(SELECT sum((B.cantidad * (B.precio - B.descuento)) + (B.cantidad * B.impuesto1))
		FROM [normac].[dbo].[Facturacion_FacturaH]A
		join [dbo].[Facturacion_FacturaD]B
		on A.id = B.id_facturaH
		where A.numero_documento = C.num_doc) as valor_factura
	  ,(SELECT A.id_cliente
		FROM [normac].[dbo].[Facturacion_FacturaH]A
		--join [dbo].[Facturacion_FacturaD]B
		--on A.id = B.id_facturaH
		where A.numero_documento = C.num_doc) as id_cliente
	  ,(SELECT A.cliente_nombre
		FROM [normac].[dbo].[Facturacion_FacturaH]A
		--join [dbo].[Facturacion_FacturaD]B
		--on A.id = B.id_facturaH
		where A.numero_documento = C.num_doc) as nombreCliente
      ,[date_modified]
      ,[date_created]
      ,[id_recibo_h]
      ,[id_tipo_pago]
      ,[id_banco]
      ,[numero_cheque]
      ,[nombre_emisor]
      ,[id_cuenta]
      ,[numero_cuenta]
      ,[num_docbk]
      ,[is_abono_factura_credito]
      ,[id_user_modified]
  FROM [normac].[dbo].[Facturacion_ReciboD]C
  where cast(date_created as date) = '12/29/2025'--La fecha del cierre a revisar
		and id_tipo_pago = 2